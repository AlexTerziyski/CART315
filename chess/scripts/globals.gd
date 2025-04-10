extends Node

enum PLAYER { ONE, TWO }
enum PLAYER_2_TYPE { 
	HUMAN, AI
}

enum COLORS {
	BLACK, WHITE
}

enum PIECE_TYPES {
	ROOK,
	KNIGHT,
	BISHOP,
	QUEEN,
	KING,
	PAWN
}

const SPRITE_MAPPING = {
	COLORS.BLACK : {
		PIECE_TYPES.ROOK: Vector2i(0, 4),
		PIECE_TYPES.KNIGHT: Vector2i(0, 3),
		PIECE_TYPES.BISHOP: Vector2i(0, 2),
		PIECE_TYPES.QUEEN: Vector2i(0, 1),
		PIECE_TYPES.KING: Vector2i(0, 0),
		PIECE_TYPES.PAWN: Vector2i(0, 5),
	},
	COLORS.WHITE:{
		PIECE_TYPES.ROOK: Vector2i(1, 4),
		PIECE_TYPES.KNIGHT: Vector2i(1, 3),
		PIECE_TYPES.BISHOP: Vector2i(1, 2),
		PIECE_TYPES.QUEEN: Vector2i(1, 1),
		PIECE_TYPES.KING: Vector2i(1, 0),
		PIECE_TYPES.PAWN: Vector2i(1, 5),
	},
}

const INITIAL_PIECE_SET_SINGLE = [
	[PIECE_TYPES.ROOK, 0, 0],
	[PIECE_TYPES.KNIGHT, 1, 0],
	[PIECE_TYPES.BISHOP, 2, 0],
	[PIECE_TYPES.QUEEN, 3, 0],
	[PIECE_TYPES.KING, 4, 0],
	[PIECE_TYPES.BISHOP, 5, 0],
	[PIECE_TYPES.KNIGHT, 6, 0],
	[PIECE_TYPES.ROOK, 7, 0],
	[PIECE_TYPES.PAWN, 0, 1],
	[PIECE_TYPES.PAWN, 1, 1],
	[PIECE_TYPES.PAWN, 2, 1],
	[PIECE_TYPES.PAWN, 3, 1],
	[PIECE_TYPES.PAWN, 4, 1],
	[PIECE_TYPES.PAWN, 5, 1],
	[PIECE_TYPES.PAWN, 6, 1],
	[PIECE_TYPES.PAWN, 7, 1]
]
