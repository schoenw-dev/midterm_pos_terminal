# midterm_pos_terminal
Grand Circus midterm point of sale terminal project
MVP modifacations:

Items class needs an additional property called "category". Our "Hot foods" & "Soft serve" could just be a "category" of item.

12 items stored in a text file.  The MVP only have 4 items, so using the other premade item classes will make expanding our list straightforward

Present menu to the user and let them choose item.  We must add a function that takes in a number and modifies the order, and calcuates price

Either through a menu or seperate question allow them to re-display the menu and to complete purchase.  MVP writes the order to a text file, implmentation should be easy

Give sub total, sales tax, and grand total. Abstract method that calucalates price and pulls the local sales tax from a text file.

Use an Abstract Class or an Interface for the various payment methods, include a seperate class for each payment methoid that inherits from that parent class.

Display a reciept with all items ordered, subtotal, and grand total and appropriate payment info.

Return to the original meni for a new order (you'll want an array or list to keep track of whats been ordered.  (Already have a way to implement this with the writer)

Optional Enhancements:

(Moderate) include and option to add the product list, which then outputs to the product file (Already wrote a writer method that can do this)
