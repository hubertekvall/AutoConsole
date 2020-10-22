using System;
using System.Collections.Generic;


namespace AutoConsole
{
    public class ConsoleEngine<T>
    {
        static Dictionary<string, T> _variables;
        static Dictionary<string, T> variables
        {
            get
            {
                if (_variables is null) _variables = new Dictionary<string, T>();
                return _variables;
            }
        }


        public static void RegisterVariable(string name, T value = default(T))
        {
            variables.Add(name, value);
        }


        public static void SetVariable(string name, T value)
        {
            variables[name] = value;
        }

        public static T GetVariable(string name)
        {
            return variables[name];
        }




    }
}