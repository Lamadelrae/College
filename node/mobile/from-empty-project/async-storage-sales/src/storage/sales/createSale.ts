import AsyncStorage from "@react-native-async-storage/async-storage";

import { SaleDTO } from "./SaleDTO";
import { SALE_CONTROL } from "../StorageConfig";
import { getAllSales } from "./getAllSales";

export async function addSale(sale: SaleDTO) {
  try {
    const supplierControl = await getAllSales();

    const storage = [...supplierControl, sale];

    const data = await AsyncStorage.setItem(
      SALE_CONTROL,
      JSON.stringify(storage)
    );

    return data;
  } catch (error) {
    console.log(error);
    throw error;
  }
}
