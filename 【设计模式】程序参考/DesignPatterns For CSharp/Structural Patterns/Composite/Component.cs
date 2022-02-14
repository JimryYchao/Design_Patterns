﻿namespace DesignPatterns_For_CSharp.Structural_Patterns.Composite
{
    public interface IComponent
    {
        protected bool isLeaf { get; set; }
        abstract public void Operation();
        abstract public int Add(IComponent component);
        abstract public bool Remove(IComponent component);
        abstract public IComponent GetChild(int index);
    }
}
