using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_13_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Parent
    {
        void DoThis(){ }
        public virtual void DoThat() { }
    }
    class Child : Parent
    {
        // can override parent method : polymorphism

        public override void DoThat()
        {
            base.DoThat();
        }
    }class Child2 : Parent
    {
        // can override parent method : polymorphism

        public override void DoThat()
        {
            base.DoThat();
        }
    }class Child3 : Parent
    {
        // can override parent method : polymorphism

        public override void DoThat()
        {
            base.DoThat();
        }
    }class Child4 : Parent
    {
        // can override parent method : polymorphism

        public override void DoThat()
        {
            base.DoThat();
        }
    }
}
