using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathemForFractionAndPoint {
    internal interface IMathem {
        public void Add(object obj, object obj2)=> Add(obj, obj2);
        public void Subtract(object obj, object obj2)=> Subtract(obj, obj2);
        public void Multiply(object obj, object obj2) => Multiply(obj, obj2);
        public void Divide(object obj, object obj2) =>  Divide(obj, obj2);

    }
}
