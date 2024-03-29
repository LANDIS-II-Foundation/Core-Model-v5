using Edu.Wisc.Forest.Flel.Util;

namespace Landis.Ecoregions
{
	/// <summary>
	/// Editable set of parameters for an ecoregion.
	/// </summary>
	public interface IEditableParameters
		: IEditable<IParameters>
	{
		/// <summary>
		/// Name
		/// </summary>
		InputValue<string> Name
		{
			get;
			set;
		}

		//---------------------------------------------------------------------

		/// <summary>
		/// Description, e.g., "wetlands", "water", or "pine barrens".
		/// </summary>
		InputValue<string> Description
		{
			get;
			set;
		}

		//---------------------------------------------------------------------

		/// <summary>
		/// Code that identifies the ecoregion on a map.
		/// </summary>
		InputValue<ushort> MapCode
		{
			get;
			set;
		}

		//---------------------------------------------------------------------

		/// <summary>
		/// Indicates whether the sites in the ecoregion are active in a
		/// scenario.
		/// </summary>
		InputValue<bool> Active
		{
			get;
			set;
		}
	}
}
