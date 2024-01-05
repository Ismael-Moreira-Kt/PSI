import pygame
from dimensao import obter_dimensoes



pygame.init()



width, height = obter_dimensoes()
janela = pygame.display.set_mode((width,height))
pygame.display.set_caption(("Crônicas da Ruína"))


deve_continuar = True


while deve_continuar:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            deve_continuar = False



pygame.quit()