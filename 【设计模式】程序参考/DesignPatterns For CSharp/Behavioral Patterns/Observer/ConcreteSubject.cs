using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Observer
{
    public class ConcreteSubject : ISubject
    {
        ChangeManager changeMgr;
        public ConcreteSubject(ChangeManager manager)
        {
            this.changeMgr = manager;
        }
        public void Attach(IObserver o)
        {
            changeMgr.Register(this, o);
        }
        public void Detach(IObserver o)
        {
            changeMgr.Unregister(this, o);
        }
        public void Notify()
        {
            changeMgr.Notify(); 
        }
    }
}
