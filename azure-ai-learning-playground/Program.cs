//Load sample data
using Azure_ai_learning_playground;

var sampleData = new RegularExpressionModel.ModelInput()
{
    Type = "Individual Home",
    City = "Chennai"
};

//Load model and predict output
var result = RegularExpressionModel.Predict(sampleData);
Console.WriteLine(result.Score);
