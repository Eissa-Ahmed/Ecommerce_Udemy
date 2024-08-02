﻿global using AutoMapper;
global using Ecommerce.Application.ApplicationValidation;
global using Ecommerce.Application.Feature.CategoryFeature.Queries.Models;
global using Ecommerce.Application.Feature.CategoryFeature.Queries.Result;
global using Ecommerce.Application.ResponseManager;
global using Ecommerce.Application.Services;
global using Ecommerce.Application.Services.IServices;
global using Ecommerce.Domain.Entities;
global using Ecommerce.Domain.IRepositories.IUnitOfWork;
global using Ecommerce.Domain.ISpecification;
global using Ecommerce.Infrastucture.Specification.Models;
global using FluentValidation;
global using MediatR;
global using Microsoft.AspNetCore.Http;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using System.Net;
global using System.Reflection;
global using System.Text.Json;