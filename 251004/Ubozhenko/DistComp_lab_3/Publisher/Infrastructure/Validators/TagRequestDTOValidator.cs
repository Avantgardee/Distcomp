﻿using FluentValidation;
using Publisher.DTO.RequestDTO;

namespace Publisher.Infrastructure.Validators;

public class TagRequestDTOValidator : AbstractValidator<LabelRequestDTO>
{
    public TagRequestDTOValidator()
    {
        RuleFor(dto => dto.Name).Length(2, 32);
    }
}