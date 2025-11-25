namespace CSM_Database_Core.Core.Errors;


public class EntityValidationError
    : Exception {

    public Type Set;
    public (string Property, XIValidator_Evaluate[])[] Unvalidations;

    public EntityValidationError(Type Set, bool IsRead, (string Property, XIValidator_Evaluate[])[] Unvalidations)
        : base($"{(IsRead ? "Evaluate Reading" : "Evluate Writting")} failed for ({Set}) with ({Unvalidations.Length}) faults. [{ string.Join(" | ", Unvalidations.Select(i => $"{{{i.Property}}} ({i.Item2[0].Message})")) }]") {
        this.Set = Set;
        this.Unvalidations = Unvalidations;
    }
}
