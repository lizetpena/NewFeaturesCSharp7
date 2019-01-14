using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Features
{
    class ThrowExpressions
    {

        private ConfigResource loadedConfig = LoadConfigResourceOrDefault() ??
                                    throw new InvalidOperationException("Could not load config");

        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value ??
                throw new ArgumentNullException(paramName: nameof(value), message: "New name must not be null");
        }

        private static ConfigResource LoadConfigResourceOrDefault()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// This is purely academic to show exception filters in the catch block with OR operations
        /// in the type of exceptions captured.
        /// </summary>
        public void ConvertName()
        {
            try
            {
                DoSomethingThatCanGoWrong(_name);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidCastException || ex is NotImplementedException)
            {
                HandleException(ex);
            }

        }

        private void HandleException(Exception ex)
        {
            throw new NotImplementedException();
        }

        private void DoSomethingThatCanGoWrong(string name)
        {
            throw new NotImplementedException();
        }
    }

    internal class ConfigResource
    {
    }
}
