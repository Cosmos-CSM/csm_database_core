using CSM_Foundation.Database;

namespace CSM_Foundation_Database.Entities.Bases;


/// <summary>
///     Represents an <see cref="IEntity"/> with enablement control.
/// </summary>
public interface IEnabledEntity 
    : IEntity {

    /// <summary>
    ///     Whether is enabled.
    /// </summary>
    bool IsEnabled { get; set; }
}

/// <summary>
///     Represents an <see cref="IEntity"/> with enablement control.
/// </summary>
public abstract class BEnabledEntity
    : BEntity, IEntity {

    public bool IsEnabled { get; set; } = false;
}
