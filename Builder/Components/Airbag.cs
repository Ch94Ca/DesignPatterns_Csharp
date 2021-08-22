using Builder.Components.Enums;

namespace Builder.Components
{
    class Airbag
    {
        public AirbagManufacturers AirbagManufacturer { get; set; }

        public Airbag(AirbagManufacturers airbagManufacturer)
        {
            AirbagManufacturer = airbagManufacturer;
        }
    }
}
