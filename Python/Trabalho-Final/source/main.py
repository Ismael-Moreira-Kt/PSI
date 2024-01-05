import pygame
import math

from dimensao import obter_dimensoes
from cores import *



pygame.init()


width, height = obter_dimensoes()
janela = pygame.display.set_mode((width,height))
janela.fill(BRANCO)


pygame.display.set_caption(("Crônicas da Ruína"))
pygame.display.update()

deve_continuar = True


while deve_continuar:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            deve_continuar = False



pygame.quit()