using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflection
{
    class ConcreteDice : Dice
    {
        int rollValue;
        object classInstance;
        string assemName = Application.StartupPath + "//Dice.dll";
        string condition = Form1.getCondition();

        public int setRollValue()
        {
            Assembly assem = Assembly.LoadFrom(assemName);
            Type[] types = assem.GetTypes();

            foreach (var typeItem in types)
            {
                classInstance = Activator.CreateInstance(typeItem);

                MethodInfo[] methods = typeItem.GetMethods();
                foreach (var methodItem in methods)
                {
                    if (methodItem.Name == condition)
                    {
                        rollValue = (int)typeItem.InvokeMember(methodItem.Name, BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public, null, classInstance, null);
                    }
                }
            }
            return rollValue;
        }
        public override int roll
        {
            get { return this.setRollValue(); }
        }//roll
    }//ConcreteDice
}
