import pygame
import sys
import random

# CONSTANTS
SCREEN_W = 640
SCREEN_H = 480

BRICK_W = 60
BRICK_H = 15

PADDLE_W = 60
PADDLE_H = 12

BALL_DIAMETER = 16
BALL_RADIUS = int (BALL_DIAMETER / 2)

MAX_PADDLE_X = SCREEN_W - PADDLE_W
MAX_BALL_X = SCREEN_W - BALL_DIAMETER


# State Machine
S_BALL_IN_PADDLE = 0
S_PLAYING = 1
S_WON = 2
S_GAME_OVER = 3

MAX_PADDLE_X = SCREEN_W - PADDLE_W
MAX_BALL_X = SCREEN_W - BALL_DIAMETER
MAX_BALL_Y = SCREEN_H - BALL_DIAMETER
PADDLE_Y = SCREEN_H - PADDLE_H - 10


# Induce Seizure
r = random.randint(0,255)
g = random.randint(0,255)
b = random.randint(0,255)

# Colors
BLACK = (0,0,0)
GRAY  = (102,102,102)  
WHITE = (255,255,255)
RED   = (255,0,0)
GREEN = (0,255,0)
BLUE  = (0,0,255)
GOLD  = (135,113,72) 
DANK_MAGENTA = (255,0,255)
SEIZURE = (r,g,b)




class OUBreakout(object):
  def __init__(self):
    # Initialize pygame and clock
    pygame.init()
    self.screen = pygame.display.set_mode((SCREEN_W, SCREEN_H))
    pygame.display.set_caption("OU Breakout")
    self.clock = pygame.time.Clock()

    # Make sure we can use fonts
    if pygame.font:
      self.font = pygame.font.Font(None, 30)
    else:
      self.font = None

    # Initialize game data
    self.initialize_game()
    
  # Setup the game variables.  This function will be called whenever we restart the game.
  def initialize_game(self):
    self.lives = int(input("How many lives do you want? More = easier ;) "))
    self.score = 0
    self.state = S_BALL_IN_PADDLE

    self.paddle = pygame.Rect(300, PADDLE_Y, PADDLE_W, PADDLE_H)
    self.ball   = pygame.Rect(300, PADDLE_Y - BALL_DIAMETER, BALL_DIAMETER, BALL_DIAMETER)
    self.ball_velocity = [5, -5]

    self.create_bricks()
    
  # Create the bricks (pygame.Rects) for the current level.
  # The 10 and 5 are spacers to make sure bricks aren't touching.
  def create_bricks(self):
    y_ofs = 35
    self.bricks = []
    for i in range(7): # Iterate over rows
      x_ofs = 35
      for j in range(8): # Iterate over columns
        self.bricks.append(pygame.Rect(x_ofs,y_ofs,BRICK_W,BRICK_H))
        x_ofs += BRICK_W + 10
      y_ofs += BRICK_H + 5

  # Handle user keyboard input
  def check_input(self):
    keys = pygame.key.get_pressed()

    # Exit game
    if keys[pygame.K_ESCAPE]:
      sys.exit()

    # Move paddle left
    if keys[pygame.K_LEFT]:
      self.paddle.left -= 5
      if self.paddle.left < 0:
        self.paddle.left = 0

    # Move paddle right
    if keys[pygame.K_RIGHT]:
      self.paddle.left += 5
      if self.paddle.left > MAX_PADDLE_X:
        self.paddle.left = MAX_PADDLE_X

    # Shoot ball
    if keys[pygame.K_SPACE] and self.state == S_BALL_IN_PADDLE:
      self.ball_velocity = [5, -5]
      self.state = S_PLAYING

    # Restart game if won/lost
    elif keys[pygame.K_RETURN] and (self.state == S_GAME_OVER or self.state == S_WON):
      self.initialize_game()

  # Move the ball within the bounds of the screen
  def move_ball(self):
    self.ball.left += self.ball_velocity[0]
    self.ball.top  += self.ball_velocity[1]

    # Check ball location to ensure it is in a valid state, bounce otherwise
    # A bounce means flipping the sign of the velocity of the direction it was going
    if self.ball.left <= 0:
      self.ball.left = 0
      self.ball_velocity[0] = -self.ball_velocity[0]
    elif self.ball.left >= MAX_BALL_X:
      self.ball.left = MAX_BALL_X
      self.ball_velocity[0] = -self.ball_velocity[0]

    if self.ball.top < 0:
      self.ball.top = 0
      self.ball_velocity[1] = -self.ball_velocity[1]

  # Check if ball collides with (1) bricks or (2) paddle
  def handle_collisions(self):
    # Check every brick until a collision is found, then bail out
    for brick in self.bricks:
      if self.ball.colliderect(brick):
        self.score += 1
        self.ball_velocity[1] = -self.ball_velocity[1]
        self.bricks.remove(brick)
        break

    # No more bricks?  You won!
    if len(self.bricks) == 0:
      self.state = S_WON

    # Paddle collision
    if self.ball.colliderect(self.paddle):
      self.ball.top = PADDLE_Y - BALL_DIAMETER
      self.ball_velocity[1] = -self.ball_velocity[1]
    elif self.ball.top > self.paddle.top:
      self.lives -= 1
      if self.lives > 0:
        self.state = S_BALL_IN_PADDLE
      else:
        self.state = S_GAME_OVER

  # Draw player stats to screen
  def show_stats(self):
    if self.font:
      font_surface = self.font.render("Blocks Hit: " + str(self.score) + " | " "Lives Left: " + str(self.lives), False, WHITE)
      self.screen.blit(font_surface, (185,5))

  # Show a message to the user
  def show_message(self,message):
    if self.font:
      size = self.font.size(message)
      font_surface = self.font.render(message, False, WHITE)
      x = (SCREEN_W - size[0]) / 2
      y = (SCREEN_H - size[1]) / 2
      self.screen.blit(font_surface, (x,y))

  # Draw active bricks to screen
  def draw_bricks(self):
    for brick in self.bricks:
      pygame.draw.rect(self.screen, SEIZURE, brick)

  # Our main game function
  def run(self):
    while True: # Forever loop

      # Handle clicking the 'X' to close
      for event in pygame.event.get():
        if event.type == pygame.QUIT:
          sys.exit()

      # Lock to 60FPS and redraw screen
      self.clock.tick(60)
      self.screen.fill(DANK_MAGENTA)

      # Handle user input
      self.check_input()

      # Game state machine
      if self.state == S_PLAYING: # ball in play
        self.move_ball()
        self.handle_collisions()

      elif self.state == S_BALL_IN_PADDLE: # waiting to launch
        self.ball.left = self.paddle.left + self.paddle.width / 2
        self.ball.top  = self.paddle.top  - self.ball.height
        self.show_message("Press space to launch the ball.")

      elif self.state == S_GAME_OVER: # game over - no more lives
        self.show_message("You lost...press enter to restart or esc to quit")

      elif self.state == S_WON: # game over - no more bricks
        self.show_message("Yay! You won. Press enter to play again! (or press esc to quit)")

      # Draw bricks, paddle, ball
      self.draw_bricks()
      pygame.draw.rect(self.screen, SEIZURE, self.paddle)
      pygame.draw.circle(self.screen, WHITE, (self.ball.left + BALL_RADIUS, self.ball.top + BALL_RADIUS), BALL_RADIUS)
 
      # Show the player statistics
      self.show_stats()

      # Finish the drawing process (flip drawing buffer)
      pygame.display.flip()

### MAIN
if __name__ == '__main__':
  breakout = OUBreakout()
  breakout.run()
