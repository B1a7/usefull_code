using System;

public class StringLiteral
{
	public StringLiteral()
	{
		//old way 

		string filemname1 = "c:\\documents\\file.txt";
        string filemname2 = @"c:\documents\file.txt";
        string filemname3 = @"c:\docu""ments\file.txt";

        // C#11 feature string literal
        string filemname4 = """c:\docu""ments\file.txt""";
        string filemname4 = $$"""
            c:\docu""
            ments\file. is {{someFile}}
            txt
            {
                "name": "Firstname"
            }
            """;

        var rating = 3;

        var message = $"rating of {rating switch
        {
            < 3 => "sucks",
            _ => "notbad"
        }}";

        // UTF8 encoding

        var oldEncoding = Encoding.UTF8.GetBytes("test value");

        var newEncoding = "test value".u8.ToArray(); // only on string hardcoded in our code

    }
}
