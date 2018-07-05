import pygame
import random

pygame.init()
screen = pygame.display.set_mode((640, 480))

x = 0
y = 0

# Set 60 fps so that machines with faster processors don't get faster movement
clock = pygame.time.Clock()
    
done = False
while not done:
    # so it doesn't hang and kill your computer
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
                done = True
                
    clock.tick(2000)
                
    r = random.randint(0,255)
    g = random.randint(0,255)
    b = random.randint(0,255)
    
    #x = random.randint(0, 640 - 60)
    #y = random.randint(0, 480 - 60)

    
    keys = pygame.key.get_pressed()
    if keys[pygame.K_LEFT]:
        x -= 1
    if keys[pygame.K_RIGHT]:
        x += 1
    if keys[pygame.K_UP]:
        y -= 1
    if keys[pygame.K_DOWN]:
        y += 1
    
    screen.fill((0,0,128))
    pygame.draw.rect(screen, (r, g, b), pygame.Rect(x, y, 60, 60))
    pygame.display.flip()