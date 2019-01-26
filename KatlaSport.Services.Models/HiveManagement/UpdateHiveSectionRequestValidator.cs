﻿using FluentValidation;

namespace KatlaSport.Services.HiveManagement
{
    /// <summary>
    /// Represent a validator for <see cref="UpdateHiveSectionRequestValidator"/>
    /// </summary>
    class UpdateHiveSectionRequestValidator : AbstractValidator<UpdateHiveSectionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateHiveSectionRequestValidator"/> class.
        /// </summary>
        public UpdateHiveSectionRequestValidator()
        {
            RuleFor(r => r.Name).Length(4, 60);
            RuleFor(r => r.Code).Length(5);
            RuleFor(r => r.StoreHiveId).GreaterThan(0);
        }
    }
}
