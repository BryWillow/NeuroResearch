namespace NeuroDomain;

/// <summary>
/// A simple definition of a Sodium Atom, including Mass and Counts.
/// </summary>
public class SodiumAtomDefinition : AtomDefinition
{
    public override int AtomicNumber => 11;
    public override int AtomicMass => 23;
    public override int ProtonCount => 11;
    public override int ElectonCount => 11;
    public override int NeutronCount => 12;
}

/// <summary>
/// This class is just an empty shell indicating what ion/neuron/trial it belongs to.
/// </summary>
/// <param name="atomDefinition"></param>
/// 
/// <remarks>
///The smallest unit of Sodium with no electrical charge.
/// </remarks>
public class SodiumAtom(AtomDefinition atomDefinition)
{
    public AtomDefinition AtomDefinition { get; init; } = atomDefinition;

    // IonIds are not unique across trial runs.
    public int IonId { get; init; } = 0;
}

/// <summary>
/// Turns a Sodium Atom into a Sodium Ion.
/// Go to the factory to assign the create a new Ion and possibly new Neuron.
/// </summary>
/// <param name="sodiumAtom"></param>
/// 
/// <remarks>
/// 
/// </remarks>
public class SodiumAtomIonizer(SodiumAtom sodiumAtom)
{    
    public SodiumAtom SodiumAtom { get; init; } = sodiumAtom;

    public IonResult LoseElectron(SodiumAtomDefinition sodium, int electronCountLost)
    {
        if (electronCountLost <= 0)
            throw new InvalidOperationException("Electrons lost must be >= 0");

        // Go out to the factory to create a new Ion
        throw new NotImplementedException();
    }
}