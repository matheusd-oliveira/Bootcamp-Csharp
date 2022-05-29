using System.Text;

var sb = new StringBuilder();
sb.AppendLine("Caracteres na primeira linha para ler");
sb.AppendLine("e a segunda linha");
sb.AppendLine("e o fim");

using var sr = new StringReader(sb.ToString());

var texto = sr.ReadToEnd();