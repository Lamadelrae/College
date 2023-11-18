import AsyncStorage from "@react-native-async-storage/async-storage";

import { SALE_CONTROL } from "../StorageConfig";

import { SaleDTO } from "./SaleDTO";

export async function getAllSales() {
  try {
    const storage = await AsyncStorage.getItem(SALE_CONTROL);

    const spending: SaleDTO[] = storage ? JSON.parse(storage) : [];
    return spending;
  } catch (error) {
    throw error;
  }
}
