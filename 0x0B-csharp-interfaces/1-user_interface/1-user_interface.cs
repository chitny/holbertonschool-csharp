using System;

///<summary>Base class</summary>
public abstract class Base
{
	/// <summary>property</summary>
  	public string name { get; set; }

	public override string ToString()
	{
		return (this.name + " is a " + this.GetType().ToString());
	}
}

/// <summary> Interactive interface </summary>
public interface IInteractive
{
    void Interact();

}

/// <summary> Breakable Interface </summary>
public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary> Collectable Interface </summary>
public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();

}

/// <summary> Class that inherits from Base class and all interfaces </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	public int durability { get; set; }
	public bool isCollected { get; set; }
	public string name { get; set; }

    /// <summary> Takes place when the object interacts with something </summary>
	public void Interact()
	{

	}

    /// <summary> Takes place when the object brakes. </summary>
	public void Break()
	{

	}

    /// <summary> Takes place when the object collects something.</summary>
	public void Collect()
	{

	}
}