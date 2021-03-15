﻿using FluentValidation;

namespace Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateSportCommandValidator: AbstractValidator<CreateSportCommand>
    {
        public CreateSportCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 10 characters.");
        }
    }
}