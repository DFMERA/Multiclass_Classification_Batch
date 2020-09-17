# Batch predictions for a Multiclass Classification

El framework [ML.NET](https://dotnet.microsoft.com/apps/machinelearning-ai/ml-dotnet) es de gran utilidad para crear aplicaciones con Machine Learning de punta a punta -end to end-, 
es decir, desde el entrenamiento de un modelo con datos históricos hasta la inferencia o predicción de un resultado con nuevos datos. 
Cuando creamos una aplicación utilizando [ML.NET Model Builder](https://dotnet.microsoft.com/apps/machinelearning-ai/ml-dotnet/model-builder) 
podemos hacer predicciones de un resultado o una predicción a la vez, pero hay ocaciones en que necesitamos hacer muchas predicciones a la vez en forma de batch. En este post haremos un ejercicio para crear una aplicación que predice la cancelación de una reserva de hotel y modificaremos el código para hacer predicciones en batch a partir de varios registros en un archivo .csv.

La descripción completa del problema y la solución la pueden ver en el blog [acelera.tech](https://acelera.tech/2020/09/17/machine-learning-como-hacer-predicciones-en-batch-usando-ml-net/)

The ML.NET framework is very useful for creating end-to-end Machine Learning applications,
that is, from the training of a model with historical data to the inference or prediction of a result with new data.
When we create an application using ML.NET Model Builder
We can make predictions of one outcome or one prediction at a time, but there are times when we need to make many predictions at once in batch form. In this post we will do an exercise to create an application that predicts the cancellation of a hotel reservation and we will modify the code to make batch predictions from several records in a .csv file.
