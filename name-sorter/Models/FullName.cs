namespace name_sorter.Models;

//********************************************************************
// Implement equality comparison to enable list comparison.
// CollectionAssert.AreEqual by default checks for reference equality. 
//********************************************************************

/// <summary>
/// Represents a full name.
/// </summary>
public class FullName : IEquatable<FullName>
{
    public string GivenName1 { get; set; } = "";
    public string GivenName2 { get; set; } = "";
    public string GivenName3 { get; set; } = "";
    public string LastName { get; set; } = "";

    /// <summary>
    /// Gets the full name as a string.
    /// </summary>
    /// <returns>The full name.</returns>
    public override string ToString()
    {
        if (!string.IsNullOrEmpty(GivenName3))
        {
            return string.Concat(GivenName1, " ", GivenName2, " ", GivenName3, " ", LastName);
        }

        if (!string.IsNullOrEmpty(GivenName2))
        {
            return string.Concat(GivenName1, " ", GivenName2, " ", LastName);
        }

        return string.Concat(GivenName1, " ", LastName);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        var otherFullName = obj as FullName;

        return Equals(otherFullName);

    }

    public bool Equals(FullName? other)
    {
        if (other == null) return false;
        if (other.GivenName1 != GivenName1) return false;
        if (other.GivenName2 != GivenName2) return false;
        if (other.GivenName3 != GivenName3) return false;
        if (other.LastName != LastName) return false;

        return true;
    }

    public override int GetHashCode()
    {
        // Separate instances must have the same hash code.
        return HashCode.Combine(GivenName1, GivenName2, GivenName3, LastName);
    }

    public static bool operator ==(FullName? left, FullName? right)
    {
        if (left is null)
        {
            if (right is null) return true;
            return false;
        }
        if (right is null)
        {
            if (left is null) return true;
            return false;
        }

        return left.Equals(right);
    }

    public static bool operator !=(FullName? left, FullName? right)
    {
        return !(left == right);
    }
}
