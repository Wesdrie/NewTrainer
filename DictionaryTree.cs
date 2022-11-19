using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTrainer
{
    /// <summary>
    /// BASIC TREE DESIGNED WITH KEY & VALUE PAIRS TO STORE BOTH CALL NUMBER & CALL DESCRIPTION.
    /// PARETN WILL HAVE OWN CALL NUMBER & CALL DESCRIPTION.
    /// CHILDERN WILL BE  A LIST OF CALL NUMBER & CALL DESCRIPTIONS.
    /// </summary>
    
    internal class DictionaryTree<keyType, valueType>
    {
        public IDictionary<keyType, valueType> Parent;
        public ICollection<DictionaryTree<keyType, valueType>> Children;
    }
}
