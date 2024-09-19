using Hydrophobia.Components;
using System;
using System.Collections.Generic;


namespace Hydrophobia.Entities
{
    public class Entity
    {
        private readonly Dictionary<Type, IComponent> Components;

        public Entity()
        {
            Components = new Dictionary<Type, IComponent>();
        }

        public void AddComponent(IComponent component)
        {
            Components[component.GetType()] = component;
        }

        public T GetComponent<T>() where T : class, IComponent
        {
            return Components.TryGetValue(typeof(T), out var component) ? component as T : null;
        }
    }
}
