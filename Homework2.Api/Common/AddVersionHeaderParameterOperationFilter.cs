using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Swashbuckle.Swagger;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;

namespace Homework2.Api.Common
{
    //This class is created to customize swagger ui. It creates a filter that gets version of the client's app as header.
    public class AddVersionHeaderParameterOperationFilter : Swashbuckle.AspNetCore.SwaggerGen.IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            //if no parameters exists, it creates a list of openapi parameters.
            if (operation.Parameters == null) operation.Parameters = new List<OpenApiParameter>();

            //creating the descripter of parameter.
            var descriptor = context.ApiDescription.ActionDescriptor as ControllerActionDescriptor;

            //whether controls a descripter exists or not. If exist, it wont create parameter for that controller
            // because Login and Register methods are being ignored from version controlling
            // (&& !descriptor.ControllerName.StartsWith("User")) -->  parts cause header parameter not to create for User controller.
            if (descriptor != null && !descriptor.ControllerName.StartsWith("User"))  
            {
                //adds new parameter
                operation.Parameters.Add(new OpenApiParameter()
                {
                    //parameter properties here
                    Name = "appVersion",
                    In = ParameterLocation.Header,
                    Description = "Version of the client's app.",
                    Required = true
                });
            }
        }
    }
}