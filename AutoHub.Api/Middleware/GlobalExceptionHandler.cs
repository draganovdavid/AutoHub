using AutoHub.Application.Common.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoHub.Api.Middleware
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        private readonly ILogger<GlobalExceptionHandler> _logger;

        public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
        {
            _logger = logger;
        }

        public async ValueTask<bool> TryHandleAsync(
            HttpContext httpContext,
            Exception exception,
            CancellationToken cancellationToken)
        {
            var (statusCode, title, errors) = exception switch
            {
                ValidationException validationException => (
                    StatusCodes.Status400BadRequest,
                    "Validation failed",
                    (object?)validationException.Errors),

                KeyNotFoundException => (
                    StatusCodes.Status404NotFound,
                    exception.Message,
                    null),

                DbUpdateConcurrencyException => (
                    StatusCodes.Status409Conflict,
                    "The record was modified by another request. Please reload and try again.",
                    null),

                DbUpdateException => (
                    StatusCodes.Status400BadRequest,
                    "The request could not be completed due to invalid or conflicting data.",
                    null),

                _ => (
                    StatusCodes.Status500InternalServerError,
                    "An unexpected error occurred.",
                    null)
            };

            // Логвам DB-related грешки с пълен InnerException — не се връщат
            // към клиента (избягвам да теч на детайли за схемата навън), но остават
            // видими в конзолата за диагностика по време на разработка.
            if (exception is DbUpdateException or DbUpdateConcurrencyException
                || statusCode == StatusCodes.Status500InternalServerError)
            {
                _logger.LogError(exception, "Unhandled exception");
            }

            var problemDetails = new ProblemDetails { Status = statusCode, Title = title };

            if (errors is not null)
            {
                problemDetails.Extensions["errors"] = errors;
            }

            httpContext.Response.StatusCode = statusCode;
            await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);

            return true;
        }
    }
}