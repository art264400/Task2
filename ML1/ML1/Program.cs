// See https://aka.ms/new-console-template for more information
using ML1;


//Load sample data
var sampleData = new MLModel1.ModelInput()
{
    Col0 = @"Кортошка была неплохая",
};

//Load model and predict output
var result = MLModel1.Predict(sampleData);
Console.WriteLine(result.Prediction);