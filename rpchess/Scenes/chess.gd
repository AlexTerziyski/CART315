extends Sprite2D

const BOARD_SIZE = 8
const CELL_WIDTH = 18

const TEXTURE_HOLDER = preload("res://Scenes/texture_holder.tscn")

const BLACK_BISHOP = preload("res://Assets/black_bishop.png")
const BLACK_KING = preload("res://Assets/black_king.png")
const BLACK_KNIGHT = preload("res://Assets/black_knight.png")
const BLACK_PAWN = preload("res://Assets/black_pawn.png")
const BLACK_QUEEN = preload("res://Assets/black_queen.png")
const BLACK_ROOK = preload("res://Assets/black_rook.png")
const WHITE_KING = preload("res://Assets/white_king.png")
const WHITE_KNIGHT = preload("res://Assets/white_knight.png")
const WHITE_PAWN = preload("res://Assets/white_pawn.png")
const WHITE_QUEEN = preload("res://Assets/white_queen.png")
const WHITE_ROOK = preload("res://Assets/white_rook.png")
const WHITE_BISHOP = preload("res://Assets/white_bishop.png")

const TURN_BLACK = preload("res://Assets/turn-black.png")
const TURN_WHITE = preload("res://Assets/turn-white.png")

@onready var pieces: Node2D = $Pieces
@onready var dots: Node2D = $Dots
@onready var turn: Sprite2D = $Turn

Variables
 -6 = BLACK_KING
 -5 = BLACK_QUEEN
 -4 = BLACK_ROOK
 -3 = BLACK_BISHOP
 -2 = BLACK_KNIGHT
 -1 = BLACK_PAWN
  0 = null
 6 = WHITE_KING
 5 = WHITE_QUEEN
 4 = WHITE_ROOK
 3 = WHITE_BISHOP
 2 = WHITE_KNIGHT
 1 = WHITE_PAWN
var board : Array
var white : bool
var state: bool
var moves = []
var selected_pieces : Vector2

func _ready():
	board.append([4, 2, 3, 5, 6, 3, 2, 4])
	board.append([1, 1, 1, 1, 1, 1, 1, 1])
	board.append([0, 0, 0, 0, 0, 0, 0, 0])
	board.append([0, 0, 0, 0, 0, 0, 0, 0])
	board.append([0, 0, 0, 0, 0, 0, 0, 0])
	board.append([0, 0, 0, 0, 0, 0, 0, 0])
	board.append([-1, -1, -1, -1, -1, -1, -1, -1])
	board.append([-4, -2, -3, -5, -6, -3, -2, -4])
	
	display_board()
	
func display_board():
	for i in BOARD_SIZE: 
		for j in BOARD_SIZE:
			var holder = TEXTURE_HOLDER.instantiate()
			pieces.add_child(holder)
			holder.global_position = Vector2(j * CELL_WIDTH + (CELL_WIDTH/2), -i * CELL_WIDTH - (CELL_WIDTH/2))
			
			match board[i][j]:
					-6: holder.texture = BLACK_KING
					-5: holder.texture = BLACK_QUEEN
					-4: holder.texture = BLACK_ROOK
					-3: holder.texture = BLACK_BISHOP
					-2: holder.texture = BLACK_KNIGHT
					-1: holder.texture = BLACK_PAWN
					0: holder.texture = null
					6: holder.texture = WHITE_KING
					5: holder.texture = WHITE_QUEEN
					4: holder.texture = WHITE_ROOK
					3: holder.texture = WHITE_BISHOP
					2: holder.texture = WHITE_KNIGHT
					1: holder.texture = WHITE_PAWN
  
