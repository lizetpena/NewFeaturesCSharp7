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
    }

    internal class ConfigResource
    {
    }
}
