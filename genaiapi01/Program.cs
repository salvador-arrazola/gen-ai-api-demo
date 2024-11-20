using OpenAI_API;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var api = new OpenAIAPI("my-openai-api-key");

var request = new OpenAI_API.Images.ImageGenerationRequest
{
  Prompt = "A cute kitten in a basket"
};
// var request = OpenAI_API.Images.ImageGenerationRequest
// {
//   Prompt = "A cute kitten in a basket"
// };

var response = await api.ImageGenerations.CreateImageAsync(request);
// var response = api.ImageGenerations.CreateImageAsync(request);

Console.WriteLine("Image URL: {0}", response.Data[0].Url);
// Console.WriteLine("Image URL: {0}", response.Data[0].Url);
