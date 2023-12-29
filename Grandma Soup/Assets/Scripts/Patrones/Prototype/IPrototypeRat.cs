using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Prototype.Interfaces
{
    public interface IPrototypeRat
    {
        public IPrototypeRat Clone();

        // métodos
        public bool IsAlive();
        public string GetArmy();
        public Vector2 position { get; set; }

        public Vector2 direction { get; set; }

        public void Create();
        public void Move(float deltaTime);
        public bool ProcessCollissions(IPrototypeRat other);
        public void Render();

        public void Kill();
    }
}
