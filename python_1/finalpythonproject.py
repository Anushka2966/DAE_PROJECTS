# Gather Ingredients
def gather_ingredients():
    """
    Prompts the user to choose bread, condiments, filling, toppings,
    number of sandwiches, and a tip amount.
    Returns all of these as a tuple.
    """
    bread_type = input("Choose your bread (white/whole grain): ")  # str
    condiments_used = input("Enter your condiments: ")  # str
    sandwich_filling = input("Enter your filling: ")  # str
    extra_toppings = input("Enter your extra toppings: ")  # str
    number_of_sandwiches = int(input("How many sandwiches would you like to make? "))  # int
    tip_amount = float(input("How much tip would you like to add? "))  # float
    
    return bread_type, condiments_used, sandwich_filling, extra_toppings, number_of_sandwiches, tip_amount

# Prepare Sandwiches
def prepare_sandwich(bread, condiments, filling, toppings):
    """
    Prepares a single sandwich based on provided ingredients.
    """
    print(f"Using {bread} bread.")
    print(f"Spreading {condiments} on the bread.")
    print(f"Adding {filling} as the main filling.")
    print(f"Adding toppings: {toppings}.")
    print("Closing the sandwich with another slice of bread.")
    print("One sandwich is ready!")

# Make Sandwiches
def make_sandwiches():
    """
    Gathers ingredients, prepares sandwiches as per user input,
    and displays a tip amount. Uses a list to store ingredients
    and a loop to make multiple sandwiches.
    """
    # Gather ingredients
    bread_type, condiments_used, sandwich_filling, extra_toppings, number_of_sandwiches, tip_amount = gather_ingredients()
    
    # Decision structure: Check if white bread is available, otherwise use whole grain
    if bread_type.lower() != "white" and bread_type.lower() != "whole grain":
        print("Chosen bread not available. Defaulting to whole grain.")
        bread_type = "whole grain"
    
    # List to store ingredient details
    sandwich_ingredients = [bread_type, condiments_used, sandwich_filling, extra_toppings]
    
    # Loop through the number of sandwiches requested
    for current_number in range(number_of_sandwiches):
        print(f"\nMaking sandwich #{current_number+1}:")
        prepare_sandwich(*sandwich_ingredients)
    
    # Display the tip amount
    print(f"\nTotal tip added: ${tip_amount:.2f}")

# Run the sandwich-making function
make_sandwiches()
