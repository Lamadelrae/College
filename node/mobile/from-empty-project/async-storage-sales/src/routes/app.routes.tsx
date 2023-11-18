import React from "react";
import {
  createBottomTabNavigator,
  BottomTabNavigationProp,
} from "@react-navigation/bottom-tabs";

import { Dashboard } from "../pages/Dashboard";
import { ListALl } from "../pages/ListAll";
import { SearchByCpf } from "../pages/SearchByCpf";
import { ListByCpf } from "../pages/ListByCpf";

type AppRoutes = {
  Cadastro: undefined;
  Lista: undefined;
  Pesquisa: undefined;
  PorCodigo: undefined;
};

export type AppNavigatorRoutesProps = BottomTabNavigationProp<AppRoutes>;

const { Navigator, Screen } = createBottomTabNavigator<AppRoutes>();

export function AppRoutes() {
  return (
    <Navigator
      screenOptions={{
        headerShown: false,
      }}
    >
      <Screen name="Cadastro" component={Dashboard} />
      <Screen name="Lista" component={ListALl} />
      <Screen name="Pesquisa" component={SearchByCpf} />
      <Screen name="PorCodigo" component={ListByCpf} />
    </Navigator>
  );
}
