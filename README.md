# Toner #
A C# Library for IBM's Tone Analyser

This is still a very early work in progress, as I'm currently working on the model to make the library more accessible without the need of JSON parsing.
##Example usage##
~~~ 
public static void Main(string[] args)
{
    var username = ConfigurationManager.AppSettings["Toner.Username"];
    var password = ConfigurationManager.AppSettings["Toner.Password"];
    var fetcher = new Fetcher(username, password);

    Console.WriteLine("Starting import process...");
    var result = JsonConvert
        .DeserializeObject<Result>(fetcher.GetJsonData(EndpointUrl, new Parameter(document.Text))); //map JSON to model

    HandleResult(result); //handle your result
    Console.WriteLine("Finished import process. Press any key to close this dialogue.");
    Console.ReadKey();
  }
  ~~~

## In the pipeline ##
  
  1. No manual JSON parsing step
  2. Async toning
  3. Analytics helper functions
