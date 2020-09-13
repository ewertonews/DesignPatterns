using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class FieldElement
    {
        public string ClassName;
        public string Field, Type;
        public List<FieldElement> Fields = new List<FieldElement>();
        private const int indentSize = 2;

        public FieldElement(string field, string type)
        {
            Field = field;
            Type = type;
        }

        public FieldElement()
        {

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize);
            sb.Append($"public class {ClassName}\n{{\n");
            foreach (var field in Fields)
            {
                sb.Append($"{i}public {field.Type} {field.Field};");
                sb.Append("\n");
            }
            sb.Append("}");
            return sb.ToString();
        }
    }
    public class CodeBuilder
    {
        FieldElement _class = new FieldElement();
        public CodeBuilder(string className)
        {
            _class.ClassName = className;
        }

        public CodeBuilder()
        {
        }

        public CodeBuilder AddField(string name, string type)
        {
            _class.Fields.Add(new FieldElement
            {
                Field = name,
                Type = type
            });
            return this;
        }

        public override string ToString()
        {
            return _class.ToString();
        }
    }
}
