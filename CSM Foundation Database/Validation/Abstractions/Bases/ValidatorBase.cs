using CSM_Database_Core.Validations.Abstractions.Interfaces;

namespace CSM_Database_Core.Validations.Abstractions.Bases;

/// <inheritdoc cref="IValidator"/>
[AttributeUsage(AttributeTargets.Property)]
public abstract class ValidatorBase
    : Attribute, IValidator {

    public abstract bool ValidateType(Type Type);

    public abstract bool Validate(object? value);
}
