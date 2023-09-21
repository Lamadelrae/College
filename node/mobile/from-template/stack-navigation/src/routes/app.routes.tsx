import * as React from "react";
import { NavigationContainer } from "@react-navigation/native";
import { createNativeStackNavigator } from "@react-navigation/native-stack";
import { Dashboard } from "../pages/Dashboard";
import { ListInvoice } from "../pages/ListInvoice";
import { Menu } from "../pages/Menu";

const Stack = createNativeStackNavigator();

export const Routes = () => {
  return (
    <NavigationContainer>
      <Stack.Navigator screenOptions={{ headerShown: false }}>
        <Stack.Screen name="Menu" component={Menu} />
        <Stack.Screen name="Dashboard" component={Dashboard} />
        <Stack.Screen name="ListInvoice" component={ListInvoice} />
      </Stack.Navigator>
    </NavigationContainer>
  );
};
