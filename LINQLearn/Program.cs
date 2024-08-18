
using DataLayer.Models;

//Instantiate the ViewModel

SamplesViewModel vm = new SamplesViewModel()
{
    UseQuerySyntax = true,  
};

//call a sample method

vm.OrderByDescending();

//Display Product Collection

foreach (var item in vm.Products) 
{
    Console.WriteLine(item.ToString());
}

// Display Result Text
Console.WriteLine(vm.ResultText);