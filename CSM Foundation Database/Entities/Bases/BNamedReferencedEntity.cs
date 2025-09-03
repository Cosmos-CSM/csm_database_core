using CSM_Foundation.Database;

namespace CSM_Foundation_Database.Entities.Bases;

/// <summary>
///     Represents an <see cref="IEntity"/> with <see cref="BNamedEntity.Name"/> and <see cref="BNamedEntity.Description"/> properties
///     that can help to identify a <see cref="IEntity"/> based on <see cref="BNamedEntity.Name"/> property as this defines them as unique.
/// </summary>
public interface INamedReferencedEntity
    : IEntity, IReferencedEntity, INamedEntity {
}

/// <summary>
///     Represents an <see cref="IEntity"/> with <see cref="Name"/> and <see cref="Description"/> properties
///     that can help to identify a <see cref="IEntity"/> based on <see cref="Name"/> property as this defines them as unique.
/// </summary>
public abstract class BNamedReferencedEntity
    : BEntity, INamedReferencedEntity {

    public string Name { get; set; } = string.Empty;

    public string Reference { get; set; } = string.Empty;

    public string? Description { get; set; }
}