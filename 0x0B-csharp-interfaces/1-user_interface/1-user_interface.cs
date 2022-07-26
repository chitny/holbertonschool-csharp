using System;

///<summary>Base class</summary>
abstract class Base
{
  public string name = "";

	public override string ToString()
	{
		return (this.name + " is a " + this.GetType().ToString());
	}
}

/// <summary> Interactive interface </summary>
interface IInteractive
{
    void Interact();
}

/// <summary> Breakable Interface </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary> Collectable Interface </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();

}

/// <summary> Class that inherits from Base class and all interfaces </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    ///<summary>Property durability</summary>
    public int durability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    ///<summary>Property isCollected</summary>
    public bool isCollected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    ///<summary>Property isCollected</summary>
    public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    ///<summary>Method Interact</summary>
    public void Interact()
    {
        throw new NotImplementedException();
    }
    ///<summary>Method Break</summary>
    public void Break()
    {
        throw new NotImplementedException();
    }
    ///<summary>Method Collect</summary>
    public void Collect()
    {
        throw new NotImplementedException();
    }
}