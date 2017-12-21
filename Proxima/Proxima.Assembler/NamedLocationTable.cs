using System;
using System.Collections.Generic;
using System.Linq;
using Proxima.Assembler.Exceptions;

namespace Proxima.Assembler
{
    public class NamedLocationTable
    {
        private Dictionary<String, uint?> _namedLocationTable = new Dictionary<string, uint?>();
        private object _lock = new object();

        public void AddLocation(String name, uint location)
        {
            lock (_lock)
            {
                if (_namedLocationTable.ContainsKey(name))
                {
                    if (_namedLocationTable[name].HasValue)
                    {
                        var message = $"Duplicate Location Name {name}";
                        throw new DuplicateLocationNameException(message);
                    }
                }

                _namedLocationTable[name] = location;
            }
        }

        /// <summary>
        /// This method is called to indicate a knowledge about named location before it was declared;
        /// this is to ensure that it may be used as an operand before the actual location is reached by the lexer.
        /// Registering a named location in named location table without providing location address later on will
        /// result in UnknownNamedLocationException on linking stage.
        /// </summary>
        public void AddLocation(String name)
        {
            if (!_namedLocationTable.ContainsKey(name))
            {
                lock (_lock)
                {
                    if (!_namedLocationTable.ContainsKey(name))
                    {
                        _namedLocationTable.Add(name, null);
                    }
                }
            }
        }

        public List<String> GetUnresolvableLocations()
        {
            return _namedLocationTable.Where(kv => !kv.Value.HasValue).Select(kv => kv.Key).ToList();
        }

        public long ResolveLocation(String name)
        {
            if (!_namedLocationTable.ContainsKey(name) || !_namedLocationTable[name].HasValue)
            {
                throw new CannotResolveLocationException($"Cannot resolve location {name}");
            }

            return _namedLocationTable[name].Value;
        }
    }
}
