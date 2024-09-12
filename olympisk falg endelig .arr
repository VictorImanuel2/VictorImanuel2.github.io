use context starter2024
include image 


fun drawflag(x):
  doc: "gitt verdi av (x), så vil program vise enten monokrom eller et farget flag"
  if x == "monokrom":
    blue_ring = circle(25, "outline", "black")
    yellow_ring = circle(25, "outline", "black")
    black_ring = circle(25, "outline", "black")
    green_ring = circle(25, "outline", "black") 
    red_ring = circle(25, "outline", "black")
    # setter kordinater til sirklene, utfra hvor midten er og høyden. Jeg  fant riktig kordinater ved å prøve meg frem     
    put-image(blue_ring, 95, 115, 
      put-image(yellow_ring, 120, 85,
        put-image(black_ring, 150, 115,
          put-image(green_ring, 180, 85,
            put-image(red_ring, 205, 115,
              empty-color-scene(300, 200, "white"))))))
    
            
  else if x == ("farge"):
    blue_ring = circle(25, "outline", "blue")
    yellow_ring = circle(25, "outline", "gold")
    black_ring = circle(25, "outline", "black")
    green_ring = circle(25, "outline", "green") 
    red_ring = circle(25, "outline", "red")
    
    
    put-image(blue_ring, 95, 115, 
      put-image(yellow_ring, 120, 85,
        put-image(black_ring, 150, 115,
          put-image(green_ring, 180, 85,
            put-image(red_ring, 205, 115,
              empty-color-scene(300, 200, "white"))))))
  end
end



