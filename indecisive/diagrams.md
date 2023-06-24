==============================================
        Program
----------------------------------------------
        -public Menu _menu
----------------------------------------------
        +main()
==============================================

==============================================
        Menu
----------------------------------------------
        -public Options _options
----------------------------------------------
        +Display()
            *new or returning user
                new:
                    *set ID
                    *Go back
                returning:
                    *enter ID (& load past entries)
                    *Go back


                *Add Activity
                    *Add Restaurant or Soda Shop
                        *Fast Food
                            *Name
                            *Times open
                            *Food Items
                            *Drink Items
                        *Sit Down
                            *Name
                            *Times open
                            *Food Items
                            *Drink Items
                            *Need Reservation
                        *Soda Shop
                            *Name
                            *Times open
                            *Drink Items
                    *Other Activity
                        *Indoor
                            *Name
                            *Needed Items
                        *Outdoor (or out of the house)
                            *Name
                            *Needed Items
                            *Time Available
                *Save
                *Quit
==============================================

==============================================
        Options
----------------------------------------------
        -List<Restaurant> _restaurants
        -List<Activity> _activities
----------------------------------------------
        +AddRestaurant()
        +AddActivity()
        +ChooseRandomRestaurant()
        +ChooseRandomActivity()
==============================================

==============================================
        Restaurant
----------------------------------------------
        -string _name
        -List<string> _foodItems
        -List<string> _drinkItems
        -string _timeAvailable
----------------------------------------------
        +SetName()
        +GetName()
        +SetFoodItems()
        +GetFoodItems()
        +SetDrinkItems()
        +GetDrinkItems()
        +SetTimeAvailable()
        +GetTimeAvailable()
        +abstract Stringify()
==============================================

==============================================
        FastFoodRestaurant : Restaurant
----------------------------------------------
----------------------------------------------
        +override Stringify()
==============================================

==============================================
        DessertRestaurant : Restaurant
----------------------------------------------
----------------------------------------------
        +override Stringify()
==============================================

==============================================
        SodaShop : Restaurant
----------------------------------------------
----------------------------------------------
        +override Stringify()
==============================================

==============================================
        SitDownRestaurant : Restaurant
----------------------------------------------
        -bool _needReservation
----------------------------------------------
        +SetNeedReservation()
        +GetNeedReservation()
        +override Stringify()
==============================================

==============================================
        Activity
----------------------------------------------
        -string _name
        -List<string> _neededItems
----------------------------------------------
        +GetName()
        +SetName()
        +AddNeededItems()
        +GetNeededItems()
        +abstract Stringify()
==============================================

==============================================
        OutsideActivity : Activity
----------------------------------------------
        -string _timeAvailable
----------------------------------------------
        +GetTime()
        +SetTime()
        +override Stringify()
==============================================

==============================================
        InsideActivity : Activity
----------------------------------------------
----------------------------------------------
        +override Stringify()
==============================================

==============================================
        Filehandler
----------------------------------------------
----------------------------------------------
        +Save()
        +Load()
==============================================

==============================================
        User.txt
----------------------------------------------
----------------------------------------------
        //Figure out how to format the info
==============================================