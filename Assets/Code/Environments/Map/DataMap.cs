public class DataMap{

	//Map Size
	private int _sizeX;
	private int _sizeY;
	//Map Information
	public District[] _districts;
	public DataTile[,] _tiles;

	public DataMap(int sizeX, int sizeY) {
		_sizeX = sizeX;
		_sizeY = sizeY;
	}


}
