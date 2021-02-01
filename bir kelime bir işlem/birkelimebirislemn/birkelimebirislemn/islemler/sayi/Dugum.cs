using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birkelimebirislemn.islemler.sayi
{
    public class Dugum
    {
        public int value;
        public Dugum left;
        public char? op;
        public Dugum right;

        public Dugum(Dugum left, char? op, Dugum right)
        {
            this.left = left;
            this.op = op;
            this.right = right;
        }

        public Dugum(int? value)
        {
            this.value = value.Value;
        }

        public int Evaluate()
        {
            if (this.op != null)
            {
                var lv = this.left.Evaluate();
                var rv = this.right.Evaluate();

                if (this.op == '+')
                {
                    return lv + rv;
                }
                else if (this.op == '-')
                {
                    return lv - rv;
                }
                else if (this.op == '*')
                {
                    return lv * rv;
                }
                else if (this.op == '/')
                {
                    return lv / rv;
                }
            }

            return this.value;
        }

        public override string ToString()
        {
            if (op == null)
            {
                return value.ToString();
            }
            return "(" + left.ToString() + op + right.ToString() + ")";
        }
    }
}
