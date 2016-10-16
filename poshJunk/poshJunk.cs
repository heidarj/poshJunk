using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;

namespace poshJunk
{
    [Cmdlet(VerbsCommon.Set, "RandomCase")]
    public class SetRandomCase : PSCmdlet
    {
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true,
            Position = 0
        )]
        [Alias("Input", "InputString")]
        public string String;

        [Parameter()]
        [Alias("chanceToUpper","percent")]
        public int chance;

        Random random = new Random();

        StringBuilder sb = new StringBuilder();

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }
        protected override void ProcessRecord()
        {
            //loop through all letters in the string
            foreach (char c in String.ToCharArray())
            {
                //if random.next returns a number lower than or equal to the % chance set by the "chance" parameter; set the char to upper case and add to the string to be printed
                if ((random.Next(0,100)) <= chance)
                {
                    sb.Append(c.ToString().ToUpper());
                }
                else
                {
                    sb.Append(c);
                }
            }
        } //processrecord()
        protected override void EndProcessing()
        {
            //print output to shell
            WriteObject(sb.ToString());
        }
    } // class SetRandomCase : PSCmdlet

    [Cmdlet(VerbsData.ConvertFrom, "Icelandic")]
    public class ConvertFromIcelandic : PSCmdlet
    {
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true,
            Position = 0
        )]
        [Alias("Input", "InputString")]
        public string String;

        StringBuilder sb = new StringBuilder();

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            foreach (char c in String)
            {
                switch (c)
                {
                    case 'Á':
                        sb.Append('A');
                        break;
                    case 'É':
                        sb.Append('E');
                        break;
                    case 'Í':
                        sb.Append('I');
                        break;
                    case 'Ó':
                        sb.Append('O');
                        break;
                    case 'Ú':
                        sb.Append('U');
                        break;
                    case 'Ý':
                        sb.Append('Y');
                        break;
                    case 'Æ':
                        sb.Append('A');
                        sb.Append('e');
                        break;
                    case 'Ö':
                        sb.Append('O');
                        break;
                    case 'Þ':
                        sb.Append('T');
                        sb.Append('h');
                        break;
                    case 'á':
                        sb.Append('a');
                        break;
                    case 'é':
                        sb.Append('e');
                        break;
                    case 'í':
                        sb.Append('i');
                        break;
                    case 'ó':
                        sb.Append('o');
                        break;
                    case 'ú':
                        sb.Append('u');
                        break;
                    case 'ý':
                        sb.Append('y');
                        break;
                    case 'æ':
                        sb.Append('a');
                        sb.Append('e');
                        break;
                    case 'ö':
                        sb.Append('o');
                        break;
                    case 'þ':
                        sb.Append('t');
                        sb.Append('h');
                        break;
                    default:
                        sb.Append(c);
                        break;
                } //case
            } //foreach()
        } // processRecord()

        protected override void EndProcessing()
        {
            WriteObject(sb.ToString());
        }
    } // class ConvertFromIcelandic

    /*
     
    [Cmdlet(VerbsCommon.Set, "example")]
    public class SetExample : PSCmdlet
    {
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true,
            Position = 0
        )]
        [Alias("aliasForParamName")]
        public string paramOne;

        protected override void BeginProcessing()
        {
            //runs once before processrecord()
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            //runs once for each object passed in
        } //processrecord()

        protected override void EndProcessing()
        {
            //runs once after processrecord()
            base.EndProcessing();
        }
    }

    */
}
