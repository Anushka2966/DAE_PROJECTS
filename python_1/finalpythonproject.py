# Gather Ingredients
def gather_ingredients():
    bread = input("Choose your bread (white/whole grain): ")
    condiments = input("Enter your condiments: ")
    filling = input("Enter your filling: ")
    toppings = input("Enter your extra toppings: ")
    return bread, condiments, filling, toppings

# Make the sandwich
def make_sandwich():
    # Gather ingredients
    bread, condiments, filling, toppings = gather_ingredients()
    
    # Choose your bread
    if bread == "white":
        bread = "whole grain"
    
    # Spread condiments
    print(f"Spreading {condiments} on the bread.")
    
    # Add filling
    print(f"Adding {filling} to the sandwich.")
    
    # Top it off
    print(f"Adding extra toppings: {toppings}.")
    
    # Close the sandwich
    print("Closing the sandwich with another slice of bread.")
    
    print("Your sandwich is ready!")

# Run the sandwich-making function
make_sandwich()
