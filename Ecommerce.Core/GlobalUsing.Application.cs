﻿global using AutoMapper;
global using Ecommerce.Application.ApplicationValidation;
global using Ecommerce.Application.Feature.AuthenticationFeature.Commands.Models;
global using Ecommerce.Application.Feature.AuthenticationFeature.Commands.Result;
global using Ecommerce.Application.Feature.CategoryFeature.Commands.Models;
global using Ecommerce.Application.Feature.CategoryFeature.Commands.Results;
global using Ecommerce.Application.Feature.CategoryFeature.Queries.Models;
global using Ecommerce.Application.Feature.CategoryFeature.Queries.Results;
global using Ecommerce.Application.Feature.ProductFeature.Commands.Models;
global using Ecommerce.Application.Feature.ProductFeature.Commands.Results;
global using Ecommerce.Application.Feature.ProductFeature.Queries.Models;
global using Ecommerce.Application.Feature.ProductFeature.Queries.Result;
global using Ecommerce.Application.Mapper.ProductMapper.Resolver;
global using Ecommerce.Application.PaginationManager;
global using Ecommerce.Application.ResponseManager;
global using Ecommerce.Application.Services.AttributeContainer;
global using Ecommerce.Application.Services.AuthenticationContainer;
global using Ecommerce.Application.Services.AuthenticationContainer.Token;
global using Ecommerce.Application.Services.BrandContainer;
global using Ecommerce.Application.Services.CategoryContainer;
global using Ecommerce.Application.Services.DiscountContainer;
global using Ecommerce.Application.Services.FileContainer;
global using Ecommerce.Application.Services.IServices.IAttributeContainer;
global using Ecommerce.Application.Services.IServices.IAuthenticationContainer;
global using Ecommerce.Application.Services.IServices.IAuthenticationContainer.IToken;
global using Ecommerce.Application.Services.IServices.IBrandContainer;
global using Ecommerce.Application.Services.IServices.ICategoryContainer;
global using Ecommerce.Application.Services.IServices.IDiscountContainer;
global using Ecommerce.Application.Services.IServices.IFileContainer;
global using Ecommerce.Application.Services.IServices.INotificationContainer;
global using Ecommerce.Application.Services.IServices.IProductAttributeContainer;
global using Ecommerce.Application.Services.IServices.IProductContainer;
global using Ecommerce.Application.Services.IServices.IRequestContainer;
global using Ecommerce.Application.Services.IServices.ITagContainer;
global using Ecommerce.Application.Services.NotificationContainer;
global using Ecommerce.Application.Services.ProductAttributeContainer;
global using Ecommerce.Application.Services.ProductContainer;
global using Ecommerce.Application.Services.RequestContainer;
global using Ecommerce.Application.Services.TagContainer;
global using Ecommerce.Domain.Entities;
global using Ecommerce.Domain.IRepositories.IUnitOfWork;
global using Ecommerce.Domain.ISpecification;
global using Ecommerce.Domain.Models;
global using Ecommerce.Domain.Params;
global using Ecommerce.Infrastucture.Specification.ModelsSpecifications.CategorySpecification;
global using Ecommerce.Infrastucture.Specification.ModelsSpecifications.ProductSpecification;
global using FluentValidation;
global using MailKit.Net.Smtp;
global using MediatR;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Options;
global using Microsoft.IdentityModel.Tokens;
global using MimeKit;
global using System.IdentityModel.Tokens.Jwt;
global using System.Linq.Expressions;
global using System.Net;
global using System.Reflection;
global using System.Security.Claims;
global using System.Text;
global using System.Text.Json;
