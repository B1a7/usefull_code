namespace ConstantinterpolatedStrings


public static class ApiRoutes
{
    private const string ApiBase = "/api";

	public static class Library
	{
		private const string Base = $"{ApiBase}/library";
        public const string GetById = $"{Base}/{id:guid}";
        public const string GetAll = Base;
        public const string Add = $"{Base}/{id:guid}";

        // While you had const you cannot do string interpolation now you can 
        //private const string Base = ApiBase + "/library";
        //public const string GetById = Base + "/{id:guid}";
        //public const string GetAll = Base;
        //public const string Add = Base + "/{id:guid}";
    }
}