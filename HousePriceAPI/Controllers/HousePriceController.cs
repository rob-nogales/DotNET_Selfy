﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.ML;
using Microsoft.ML;
using System.IO;
using HousePriceAPI.DataModels;

namespace HousePriceAPI.Controllers
{
    [Route("api/v1/predictions")]
    [ApiController]
    public class HousePriceController : ControllerBase
    {
        private readonly PredictionEnginePool<HousePriceData, HousePricePrediction> _predictionEnginePool;
        public HousePriceController(PredictionEnginePool<HousePriceData, HousePricePrediction> predictionEnginePool)
        {
            this._predictionEnginePool = predictionEnginePool;
        }

        [HttpPost]
        public ActionResult<float> Post([FromBody] HousePriceData data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Console.WriteLine(data.Surface);
            HousePricePrediction predictedValue = _predictionEnginePool.Predict(modelName: "HousePriceModel", example: data);


            //MLContext mlContext = new MLContext();
            //DataViewSchema predictionPipelineSchema;
            //ITransformer predictionPipeline = mlContext.Model.Load("MLmodels/MLModel.zip", out predictionPipelineSchema);
            //PredictionEngine<HousePriceData, HousePricePrediction> predictionEngine = mlContext.Model.CreatePredictionEngine<HousePriceData, HousePricePrediction>(predictionPipeline);
            //HousePriceData data2 = new HousePriceData() { Rooms = 3f, Surface = 65f, Location = 3f, Price = 0f };
            //HousePricePrediction prediction = predictionEngine.Predict(data2);

            return Ok(predictedValue.Score);
        }
    }


    [Route("api/v1/Texas")]
    [ApiController]
    public class TexasController : ControllerBase
    {
        private readonly PredictionEnginePool<TexasPriceData, TexasPricePrediction> _predictionEnginePool;
        public TexasController(PredictionEnginePool<TexasPriceData, TexasPricePrediction> predictionEnginePool)
        {
            this._predictionEnginePool = predictionEnginePool;
        }

        [HttpPost]
        public ActionResult<float> Post([FromBody] TexasPriceData data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            
            TexasPricePrediction predictedValue = _predictionEnginePool.Predict(modelName: "TexasPriceModel", example: data);


            //MLContext mlContext = new MLContext();
            //DataViewSchema predictionPipelineSchema;
            //ITransformer predictionPipeline = mlContext.Model.Load("MLmodels/MLModel.zip", out predictionPipelineSchema);
            //PredictionEngine<HousePriceData, HousePricePrediction> predictionEngine = mlContext.Model.CreatePredictionEngine<HousePriceData, HousePricePrediction>(predictionPipeline);
            //HousePriceData data2 = new HousePriceData() { Rooms = 3f, Surface = 65f, Location = 3f, Price = 0f };
            //HousePricePrediction prediction = predictionEngine.Predict(data2);

            return Ok(predictedValue.Score);
        }
    }
    [Route("api/v1/Melbourne")]
    [ApiController]
    public class MelbourneController : ControllerBase
    {
        private readonly PredictionEnginePool<MelbournePriceData, MelbournePricePrediction> _predictionEnginePool;
        public MelbourneController(PredictionEnginePool<MelbournePriceData, MelbournePricePrediction> predictionEnginePool)
        {
            this._predictionEnginePool = predictionEnginePool;
        }
        [HttpPost]
        public ActionResult<float> Post([FromBody] MelbournePriceData data)
        {
             if (!ModelState.IsValid)
             {
                 return BadRequest();
             }
            /*MelbournePriceData obiect = new MelbournePriceData()
            {
                Rooms = 2,
                Price = 0,
                Distance = 2.5F,
                Postcode = 3067,
                Bedroom2 = 2,
                Bathroom = 1,
                Landsize = 126,
                BuildingArea = 0,
                YearBuilt = 0,
                CouncilArea = "Yarra City Council",
                Regionname = "Northern Metropolitan"
            };*/
            Console.WriteLine("Hello ");
            MelbournePricePrediction predictedValue = _predictionEnginePool.Predict(modelName: "MelbournePriceModel", example: data);


            //MLContext mlContext = new MLContext();
            //DataViewSchema predictionPipelineSchema;
            //ITransformer predictionPipeline = mlContext.Model.Load("MLmodels/MLModel.zip", out predictionPipelineSchema);
            //PredictionEngine<HousePriceData, HousePricePrediction> predictionEngine = mlContext.Model.CreatePredictionEngine<HousePriceData, HousePricePrediction>(predictionPipeline);
            //HousePriceData data2 = new HousePriceData() { Rooms = 3f, Surface = 65f, Location = 3f, Price = 0f };
            //HousePricePrediction prediction = predictionEngine.Predict(data2);

            return Ok(predictedValue.Score);
        }
    }


}