import { createBottomTabNavigator } from "@react-navigation/bottom-tabs";
import { MaterialCommunityIcons } from "@expo/vector-icons";
import { Feather } from "@expo/vector-icons";
import { Dashboard } from "../pages/Dashboard";
import { ListInvoice } from "../pages/ListInvoice";
import { NavigationContainer } from "@react-navigation/native";
const { Navigator, Screen } = createBottomTabNavigator();

export function AppRoutes() {
  return (
    <NavigationContainer>
      <Navigator
        screenOptions={{
          headerShown: false,
          tabBarShowLabel: false,
          tabBarActiveTintColor: "black",
          tabBarInactiveTintColor: "grey",
          tabBarStyle: {
            height: 88,
          },
        }}
      >
        <Screen
          options={{
            tabBarIcon: ({ size, color }) => (
              <MaterialCommunityIcons
                name="desktop-mac-dashboard"
                size={size}
                color={color}
              />
            ),
          }}
          name="Dashboard"
          component={Dashboard}
        />

        <Screen
          name="ListInvoice"
          options={{
            tabBarIcon: ({ size, color }) => (
              <Feather name="list" size={size} color={color} />
            ),
          }}
          component={ListInvoice}
        />
      </Navigator>
    </NavigationContainer>
  );
}
