/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class DynamicTexture : Texture
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public bool canRescale
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "canRescale"
                );
            }
        }
        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public DynamicTexture() : base() { }

        public DynamicTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public DynamicTexture(
            string name, object options, bool generateMipMaps, Scene scene = null, System.Nullable<decimal> samplingMode = null, System.Nullable<decimal> format = null
        ) : base()
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "DynamicTexture" },
                name, options, scene, generateMipMaps, samplingMode, format
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public void scale(decimal ratio)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "scale" }, ratio
                }
            );
        }

        public void scaleTo(decimal width, decimal height)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "scaleTo" }, width, height
                }
            );
        }

        public CanvasRenderingContext2DCachedEntity getContext()
        {
            return EventHorizonBlazorInteropt.FuncClass<CanvasRenderingContext2DCachedEntity>(
                entity => new CanvasRenderingContext2DCachedEntity() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getContext" }
                }
            );
        }

        public void clear()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clear" }
                }
            );
        }

        public void update(System.Nullable<bool> invertY = null, System.Nullable<bool> premulAlpha = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "update" }, invertY, premulAlpha
                }
            );
        }

        public void drawText(string text, string font, string color, string clearColor, System.Nullable<decimal> x = null, System.Nullable<decimal> y = null, System.Nullable<bool> invertY = null, System.Nullable<bool> update = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "drawText" }, text, x, y, font, color, clearColor, invertY, update
                }
            );
        }

        public DynamicTexture clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<DynamicTexture>(
                entity => new DynamicTexture() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }
        #endregion
    }
}